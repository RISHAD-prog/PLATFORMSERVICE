using PLATFORMSERVICE.Model;

namespace PLATFORMSERVICE.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<PlatForm> GetAllPlatforms();

        PlatForm GetPlatFormById(int id);

        void CreatePlatform(PlatForm platForm);
        
    }
}
