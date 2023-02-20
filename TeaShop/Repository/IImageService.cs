namespace TeaShop.Repository
{
    public interface IImageService
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);

        public bool DeleteImage(string imageFileName);
    }
}
