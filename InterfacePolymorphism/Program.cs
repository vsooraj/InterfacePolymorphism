
using System.Collections.Generic;
namespace InterfacePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new EmaiNotificationChannel());
            encoder.RegisterNotificationChannel(new SMSNotificationChannel());
            encoder.Encode(new Video());
        }
    }
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannel;
        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();

        }
        public void Encode(Video video)
        {

            System.Console.WriteLine("Video Encoded");
        }
        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannel.Add(notificationChannel);
        }
    }
    public interface INotificationChannel
    {
        void SendNotification(Message message);
    }

    public class SMSNotificationChannel : INotificationChannel
    {
        public void SendNotification(Message message)
        {
            System.Console.WriteLine("SMS Notification");
        }

    }

    public class EmaiNotificationChannel : INotificationChannel
    {

        public void SendNotification(Message message)
        {
            System.Console.WriteLine("Email Notification");
        }

    }


}
