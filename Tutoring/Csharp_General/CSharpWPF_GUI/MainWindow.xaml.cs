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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Initialize the GUI
            InitializeComponent();
        }

        //Button_Click is our button clicked event handler initialized from our XAML file
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Changing the text from our text box
            //textBox1.Text = "Welcome to GUI C#";
            
            //Make a message box (dialog box) appear with text
            //MessageBox.Show("Changed text!");

            //Initialize the thread by passing the function
            Thread thread = new Thread(ThreadedFunction);
            //Start the thread
            thread.Start();
        }
        //This is going to be executed all on a separate thread
        private void ThreadedFunction()
        {
            //Long sleep (just to simulate busy thread)
            Thread.Sleep(3000);
            //textBox1 is owned by the application thread so you must pass it through Dispatcher.Invoke passed as a lambda function
            Dispatcher.Invoke(() => textBox1.AppendText("Hello world!\n"));
        }
    }
}
