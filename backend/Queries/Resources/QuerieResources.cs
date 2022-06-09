namespace Queries.Resources
{
    public class QuerieResources
    {
        public static string RoommQuerie = @"
            SELECT 
                g.Id AS 'Id',
                g.Name AS 'Name',
                g.Email AS 'Email',
                g.Phone AS 'Phone',
                g.Cpf AS 'Cpf',
                r.Number AS 'RoomNumber',
                r.Status AS 'RoomStatus'
            FROM guests g
            JOIN rooms r ON r.Id = g.RoomId
            WHERE r.Id = @Id";
    }
}