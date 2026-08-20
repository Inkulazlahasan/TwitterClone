using TwitterClone.Domain.Entities;

var LikeNotification = new LikeNotification(Guid.NewGuid());
var description = LikeNotification.DescribeRecord();
Console.WriteLine(description);