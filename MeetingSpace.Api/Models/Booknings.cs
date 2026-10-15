namespace Booknings.Model;
public class Bookning
{
    public int BookningId {get; set;}
    public string Roomid {get;set;}
    public string Bookedby {get; set;}
    public string title {get; set;}
    public DateTime starttime {get; set;}
    public DateTime endtime {get; set;}
}