using WalkApplicationAPI.Models.Domain;

namespace WalkApplicationAPI.Repositories.Interface
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
