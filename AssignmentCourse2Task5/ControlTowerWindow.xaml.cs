//ControlTowerWindow.xaml.cs
//By: Per Sundberg 2018-04-22.
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AssignmentCourse2Task5
{
    ///<summary>
    ///This class displays the control tower form towards the user.
    ///</summary>
    public partial class ControlTowerWindow : Window
    {
        private List<string> listFlights;

        ///<summary>
        ///Constructor same name as class.
        ///</summary>
        public ControlTowerWindow()
        {
            InitializeComponent();

            //Create local list of flights
            listFlights = new List<string>();

            //Clear registred list boxes
            ClearListBox(lstFlights);

            //Create timer that updates once every minute.
            Create1MinuteTimer();

        }

        ///<summary>
        ///Method that clear food list box.
        ///</summary>
        private void ClearListBox(ListBox list)
        {
            list.Items.Clear();
        }

        ///<summary>
        ///Method that creates a timer that updates once every minute.
        ///</summary>
        private void Create1MinuteTimer()
        {
            DispatcherTimer dispatcherTimer;
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 60);
            dispatcherTimer.Start();
        }

        ///<summary>
        ///Method that updates string with 1 minute.
        ///</summary>
        private string UpdateStrWithOneMinute(string oldString)
        {
            //Remove the last part before the minute number
            String minutesTextRemoved = oldString.Remove(oldString.Length - 13);
            //Extract the number with 4 characters as the last part
            String minutesWith6Chars = minutesTextRemoved.Substring(minutesTextRemoved.Length - 4);
            //Remove the first spaces
            String minutes = minutesWith6Chars.Trim();
            //Change minutes to int
            int num = InputUtility.ConvertToInteger(minutes);
            //Update minute with 1
            num++;
            //Save the first part before number of minutes to be able to build up new string again.
            String newText = minutesTextRemoved.Remove(minutesTextRemoved.Length - 4);
            //Add number of spaces before num to be able to get 4 characters again.
            String spacebeforeMinutes = "";//Default Num < 10.000 minuter (160 timmar)
            if (num < 10)
                spacebeforeMinutes = "   ";
            else if (num < 100)
                spacebeforeMinutes = "  ";
            else if (num < 1000)
                spacebeforeMinutes = " ";
            return newText + spacebeforeMinutes + num.ToString() + " minutes ago.";
        }

        ///<summary>
        ///Update lst flights regurarily every minute.
        ///</summary>
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
              //Get all flight from list and add 1. 
              for (int i = 0; i < lstFlights.Items.Count; i++)
              {
                String oneMinuteUpdated = UpdateStrWithOneMinute(lstFlights.Items.GetItemAt(i).ToString());
                Console.WriteLine(lstFlights.Items.GetItemAt(i).ToString());
                lstFlights.Items.RemoveAt(i);
                lstFlights.Items.Insert(i, oneMinuteUpdated);
              }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        ///<summary>
        ///Method that add subscriptions for the class.
        ///</summary>
        private void SubscribeToFlightEvent(FlightWindow fw)
        {
            fw.Started += OnStartedEventReception;
            fw.Landed += OnLandedEventReception;
            fw.ChangedRoute += OnChangedDirectionEventReception;
        }

        ///<summary>
        ///Method that creates a new WPF flight window.
        ///</summary>
        private void OpenFlightWindow(String flightNumber)
        {
            FlightWindow fw = new FlightWindow(flightNumber);
            fw.Show();

            //Subscribe to event for the specific flight.
            SubscribeToFlightEvent(fw);
        }

        ///<summary>
        ///Action to perform when Started Event is received.
        ///</summary>
        public void OnStartedEventReception(object source, string flight)
        {
            String str = CreteFlightListString(flight, "Started" , "0");
            lstFlights.Items.Add(str);
        }

        ///<summary>
        ///Action to perform when Landed Event is received.
        ///</summary>
        public void OnLandedEventReception(object source, string flight)
        {
            String str = CreteFlightListString(flight, "Landed", "0");
            lstFlights.Items.Add(str);
        }

        ///<summary>
        ///Action to perform when change direction is received.
        ///</summary>
        private void OnChangedDirectionEventReception(object source, string flight, String direction)
        {
            String str = CreteFlightListString(flight, "Now heading " + direction, "0");
            lstFlights.Items.Add(str);
        }

        ///<summary>
        ///Method that adds flight to flight list.
        ///</summary>
        private void AddFlightToList(String flightNumber)
        {
            String str = CreteFlightListString(flightNumber, "Sent to runway", "0");
            lstFlights.Items.Add(str);
        }

        ///<summary>
        ///Format a string to display flights and actions.
        ///</summary>
        private string CreteFlightListString(string flightcode, string action, string when)
        {
            string minutesAgo = "minutes ago.";
            string str = string.Format("{0} {1,45} {2,15} {3}", flightcode, action, when, minutesAgo);
            return str;
        }


        ///<summary>
        ///Action taken when button Send next to runway is pressed.
        ///</summary>
        private void btnSendPlane_Click(object sender, RoutedEventArgs e)
        {
            //Get Flight number code from form
            String flightNumber = txtNextFlight.Text.ToString();

            //If not flightnumber is added, then display popup message
            if (flightNumber.Equals(""))
            {
                MessageBox.Show("Please add a Flight code", "Error Message",MessageBoxButton.OK, MessageBoxImage.Question);
            }

            //If flightnumber is added, then continue.
            else
            {
                //Open new flight window
                OpenFlightWindow(flightNumber);

                //Store flight in flight list
                AddFlightToList(flightNumber);
            }
        }

        ///<summary>
        ///When next flight number textbox is clicked on, then empty default text.
        ///</summary>
        private void txtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtNextFlight.Text = string.Empty;
        }
    }
}
