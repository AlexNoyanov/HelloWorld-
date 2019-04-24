
/*
 * 
 * 
 * 
 * 
 
 _______                __        
|     __|.----.-----.--|  |.-----.
|    |  ||  __|  _  |  _  ||  -__|
|_______||____|_____|_____||_____|
                                  
 _______ __                                        
|     __|  |_.----.-----.---.-.--------.-----.----.
|__     |   _|   _|  -__|  _  |        |  -__|   _|
|_______|____|__| |_____|___._|__|__|__|_____|__|  

 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.IO.Ports;  // For SerialPorts

namespace GcodeStreamer
{
    public partial class Form1 : Form
    {

        SerialPort arduinoCOM;                              // Arduino COM port


        public Form1()
        {
            InitializeComponent();
            getavaialbleports();                            // Get ports when initialize
                       
        }


        public void ChooseFolder()                          // Choose folder
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
               
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        void getavaialbleports()                            // Print available ports in comboBox
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }


        string arduinoAnswer;

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)         // Serial port get some data
        {
            arduinoAnswer = arduinoCOM.ReadLine();
            
            gCode_listBox.Items.Add(arduinoAnswer);
        }

        private void serialPort1_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
        {

        }

        private void ConnectPort_button_Click(object sender, EventArgs e)
        {

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            Console.ReadLine();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            openFileDialog1.Filter = "GCODE file (*.gcode)|*.gcode";                                // Showing .gcode files only
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                // fileNameLabel.Text = openFileDialog1.FileName;
                
                string fullPath = openFileDialog1.FileName;                                         // Showing files in the file dialog window (All files in the folder)                                     
                string path = Path.GetFullPath(Path.Combine(openFileDialog1.FileName, @"..\"));     // A path to the folder 
                string fileName = Path.GetFileName(fullPath);                                       // Name of the file
               
                //string format = ".jpg";                                                           // Default format is jpeg
                string format = ".png";
                string imageName = fileName.Substring(0,fileName.Length-6) + format;
                string imagePath = path + "Images\\" + imageName;

                // Get image by this file:
                try                                                                                 // Trying to find the picture
                {
                    pictureBox1.Image = Image.FromFile(imagePath);                                  // Printing the picture       
                }catch(Exception ex)            
                {
                    fileNameLabel.Text = "  == ERROR: CAN'T OPEN IMAGE FILE! ==";                   // In case of exception print the message
                    Console.WriteLine(" == ERROR: CAN'T OPEN IMAGE FILE! ==");
                }
                fileNameLabel.Text = fullPath;                                                     // Text on the label
                Console.WriteLine(imagePath);
            }
            Console.WriteLine(result); // <-- For debugging use.

            // When file is choosed copying all data to the listbox to show it to user
            // All strings now should be choosed from File_listBox:

            List<string> fileStrings = new List<string>();                          // All strings from gcode file loading here

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(fileNameLabel.Text))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);                                           // Print it in the terminal
                    fileStrings.Add(s);                                             // Add string to the list
                    files_listBox.Items.Add(s);                                     // Adding new string to the listbox to show 
                }
            }
        }

        bool pauseBool = false;                                                     // Pause bool is desabled and Pause button not clicked

        private void GoButton_Click(object sender, EventArgs e)
        {
            // Check if serial port selected:

            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            if (comboBox1.SelectedIndex == -1)
            {
                result = MessageBox.Show("Serial port not selected!", "ERROR", buttons);
            }
            else
            {
                if (fileNameLabel.Text == "Please choose the file")
                {
                    result = MessageBox.Show("Please select the GCODE file", "ERROR", buttons);
                }
                else
                {
                    result = MessageBox.Show("Streaming started!", "Sucess", buttons);

                    // And now when all possible problems solved the code
                    //gCode_listBox.it

                    foreach (string command in gCode_listBox.Items)
                    {
                        string currentCommand = command;
                        if(pauseBool != true)                                                // Check if Pause or not
                        {
                            Console.WriteLine(command);
                            arduinoCOM.Open();
                            arduinoCOM.Write(command);
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //bool portFlag = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)         // If port is selected:
        {
            if (comboBox1.SelectedItem.ToString() != "" /*&& portFlag == false*/)
            {
                arduinoCOM = new SerialPort(comboBox1.SelectedItem.ToString());         // Creating new port for Arduino
                MessageBox.Show("CNC on port " + comboBox1.SelectedItem.ToString());
                
                //portFlag = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)           
        {
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {                                     
         
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)                          
        {
           
        }

        int dataSpeed = 1000;                                                       // Delay between data requests
        private void SendButton_Click(object sender, EventArgs e)                   // Send gcode button pressed
        {
            if (arduinoCOM == null)                                                 // If port is not selected
            {
                MessageBox.Show("Please select the port!");                         // Asking user to select it
            }
            else
            {

                // fileNameLabel.Text = textBox1.Text;   // Send command to CNC by yourself
                string yourCommand = textBox1.Text;      // Your command

                // Send this user's command to the CNC by serial port:
                arduinoCOM.Open();
                arduinoCOM.Write(yourCommand);
                Console.Write(yourCommand);
               // arduinoCOM.Close();
           
                string listCommand = "Your gcode command :" + yourCommand;

                gCode_listBox.Items.Add(listCommand);    // Add your gcode command to the list of all commands in progress list

                int dataCounter = 0;
                int maxCounter = 10;

                
                while(arduinoAnswer == null)
                {
                    arduinoAnswer = arduinoCOM.ReadLine();
                    //System.Threading.Thread.Sleep(dataSpeed);
                    if(dataCounter > maxCounter)
                    {
                        Console.WriteLine(" === Error! OUT OF TIME ===");
                        break;
                    }
                }
                
                arduinoCOM.Close();
                gCode_listBox.Items.Add(arduinoAnswer); // Add arduino answer to the list of all commands
            }
        }

        private void PauseClicked(object sender, EventArgs e)       // Pause button clicked
        {
            if(pauseBool == false)
            {
                pauseBool = true;
            }else
            {
                pauseBool = true;
            }

        }
    }
}
