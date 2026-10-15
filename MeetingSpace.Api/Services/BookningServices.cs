using Booknings.Model;
using MeetingSpace.Api.Data;
using Microsoft.EntityFrameworkCore;
namespace BookningServices;
public class BookningsService
{
    private readonly ApplicationDbContext db;
    public BookningsService(ApplicationDbContext db)
    {
        db = db;
    }
    public async Task<List<Bookning>> GetBooknings()
    {
        try
        {
            var All = await db.Booknings.ToListAsync();
            return All;
        }catch(Exception ex)
        {
            return null;        }
    }
}