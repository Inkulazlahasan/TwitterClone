
namespace TwitterClone.Domain.Entities
{
    internal class Programdemo
    {
        public void run() 
        {
            var LikeNotification = new LikeNotification(Guid.NewGuid());
            var description = LikeNotification.DescribeRecord();
        }
    }
}
