//FlightWindow.xaml.cs
//By: Per Sundberg 2018-03-22.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AssignmentCourse2Task5
{
    ///<summary>
    ///This class displays a flight window form towards the user.
    ///</summary>
    public partial class FlightWindow : Window
    {
        private Boolean headingFirstChange = false;
        private String flightCode = "";

        //Declare which delegates to use
        public delegate void TakeOffEventInfo(object source, string flight);
        public delegate void LandEventInfo(object source, string flight);
        public delegate void ChangeRouteEventInfo(object source, string flight, string direction);

        //Declare events.
        public event TakeOffEventInfo Started;
        public event LandEventInfo Landed;
        public event ChangeRouteEventInfo ChangedRoute;

        ///<summary>
        ///Constructor with same name as class.
        ///</summary>
        public FlightWindow(String flight)
        {
            InitializeComponent();

            flightCode = flight;

            //Header label with flight.
            lblFlight.Content = "Flight:" + flightCode;

            //Create image for the flight
            AddFlightImage(flightCode);

            //Create Headings table
            CreateHeadingsTable();
        }

        ///<summary>
        ///Create Image for the flight.
        ///</summary>
        private void AddFlightImage(string flight)
        {
            string flightImage = "";

            if (flight.ToUpper().Contains("KL"))
                flightImage = "klm.jpg";
            else if (flight.ToUpper().Contains("SK"))
                flightImage = "sas.jpg";
            else if (flight.ToUpper().Contains("THAI"))
                flightImage = "thai.jpg";
            else
                flightImage = "defaultImage.jpg";

            imgFlight.Source = new BitmapImage(new Uri(@"imgs/" + flightImage, UriKind.RelativeOrAbsolute));
        }

        ///<summary>
        ///Create combolist with degrees headings like 10 deg, 20 deg.....
        ///</summary>
        private void CreateHeadingsTable()
        {
            for (int i = 0; i < 370; i = i + 10)
            {
                lstHeadings.Items.Add(i + " deg");
            }

            //Set default heading 10 degrees.
            lstHeadings.SelectedIndex = 1;
        }

        ///<summary>
        ///When button Start is pressed on.
        ///</summary>
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            OnStarted(flightCode);
        }

        ///<summary>
        ///When event started is called upon.
        ///</summary>
        protected virtual void OnStarted(string flight)
        {
            if (Started != null)
                Started(this, flight);
        }

        ///<summary>
        ///When button Land is pressed on.
        ///</summary>
        private void btnLand_Click(object sender, RoutedEventArgs e)
        {
            OnLanded(flightCode);
        }

        ///<summary>
        ///When event landed is called upon.
        ///</summary>
        protected virtual void OnLanded(string flight)
        {
            if (Landed != null)
                Landed(this, flight);
        }


        ///<summary>
        ///When new heading is selected in the list.
        ///</summary>
        private void lstHeadings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstHeadings.SelectedIndex != -1)
            {
                if (headingFirstChange)
                {
                    int index = lstHeadings.SelectedIndex;
                    string heading = lstHeadings.Items.GetItemAt(index).ToString();
                    OnChangedRoute(flightCode,heading);
                }
                else
                {
                    headingFirstChange = true;
                }
            }
        }

        ///<summary>
        ///When event changed direction is called upon
        ///</summary>
        protected virtual void OnChangedRoute(string flightcode,string direction)
        {
            if (ChangedRoute != null)
                ChangedRoute(this, flightcode, direction);
        }
    }
}
