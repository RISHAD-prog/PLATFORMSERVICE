using PLATFORMSERVICE.Model;

namespace PLATFORMSERVICE.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context) {
            _context = context;
        }

        public void CreatePlatform(PlatForm platForm)
        { 
            if (platForm == null)
            {
                throw new ArgumentNullException(nameof(platForm));
            }
            else
            {
                _context.platforms.Add(platForm);
            }
        }

        public IEnumerable<PlatForm> GetAllPlatforms()
        {
            return _context.platforms.ToList();
        }

        public PlatForm GetPlatFormById(int id)
        {
            return _context.platforms.FirstOrDefault( p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0 ? true : false);
        }
    }
}
