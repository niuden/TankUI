using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class Client : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Client Net!");
        Program pp = new Program();
        pp.startnet();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Client Net Connecting!");
    }
}
class Program
{
    public void startnet()
    {
        // //创建socket
        // Socket mySocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        // //链接
        // mySocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345));
        // //接收消息
        // byte[] dataBytes = new byte[1024];
        // int count = mySocket.Receive(dataBytes);
        // string result = Encoding.UTF8.GetString(dataBytes, 0, count);
        // Console.Write(result);
        //
        // //发送一条消息
        // string sendData = Console.ReadLine();
        // mySocket.Send(Encoding.UTF8.GetBytes(sendData));
        // mySocket.Close();
        
        //创建socket
        Socket mySocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        //链接
        try
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            // mySocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345));
            mySocket.Connect(endPoint);
            Debug.Log("连接到服务器！");
            try
            {
                //接收数据
                byte[] dataBytes = new byte[1024];
                int count = mySocket.Receive(dataBytes);
                string get = mySocket.RemoteEndPoint.ToString();
                string result = Encoding.UTF8.GetString(dataBytes, 0, count);
                string sendData = DateTime.Now.ToString("Client:" + "yyyy-MM-dd HH:mm:ss:fffffff");
                Debug.Log(sendData + Encoding.UTF8.GetString(dataBytes, 0, count));
                mySocket.Send(Encoding.UTF8.GetBytes(sendData));
            }
            catch
            {
                Debug.Log("数据接收错误！");
            }
        }
        catch
        {
            Debug.Log("连接不成功！");
        }
        
        
        // while (true)
        // {
        //     //接收消息
        //     byte[] dataBytes = new byte[1024];
        //     int count = mySocket.Receive(dataBytes);
        //     string result = Encoding.UTF8.GetString(dataBytes, 0, count);
        //     // Console.Write(result);
        //     Debug.Log("result:"+result);
        //     if (result == "quit")
        //     {
        //         Debug.Log("程序结束！");
        //         mySocket.Close();
        //     }
        //     else
        //     {
        //         //发送一条消息
        //         Debug.Log("客户端发送：\n");
        //         // string sendData = Console.ReadLine();
        //         string sendData = DateTime.Now.ToString("Client:"+"yyyy-MM-dd HH:mm:ss:fffffff");
        //         mySocket.Send(Encoding.UTF8.GetBytes(sendData));
        //     }
        //
        //     // mySocket.Close();
        // }



    }
}
