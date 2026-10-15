using Booknings.Model;
using MeetingSpace.Api.Data;
using Microsoft.EntityFrameworkCore;
namespace Bookning.Services;
public class BookningService
{
    private readonly ApplicationDbContext db;
    public BookningService(ApplicationDbContext db)
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