using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleWeightChecker
{
    class Program
    {
        static SerialPort _serialPort;
        static void Main(string[] args)
        {
            _serialPort = new SerialPort();
            SerialCommunication.ConnectToSerial(_serialPort);
            
            while (SerialCommunication.ItWorked)
            {
                _serialPort.Write("p");
                System.Threading.Thread.Sleep(200);
                _serialPort.Write("0");
                Console.WriteLine(_serialPort.ReadExisting());

                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
