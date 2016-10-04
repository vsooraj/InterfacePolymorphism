
namespace InterfacePolymorphism
{
    public class NotificationChannel : INotificationChannel
    {
        #region INotificationChannel Members

        public void SendNotification(Message message)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
