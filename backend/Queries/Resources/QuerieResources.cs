namespace Queries.Resources
{
    public class QuerieResources
    {
        public static string RoommQuerie = @"SELECT 
            g.Name AS 'GuestName',
            g.Phone AS 'GuestPhone',
            r.Status AS 'RoomStatus'
            FROM rooms r
            JOIN guests AS g ON r.GuestId = g.Id
            JOIN products AS p ON r.Id = p.RoomId";
    }
}