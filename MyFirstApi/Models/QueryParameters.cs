namespace MyFirstApi.Models
{
    public class QueryParameters
    {
        const int _maxSize = 100;
        private int _size = 50;
        public int Page { get; set; } = 1;

        public int Size
        {
            get { return _size; }
            // the max amount of products returned wont be more than 100
            set
            {
                _size = Math.Min(_maxSize, value);
            }
        }
    }
}
