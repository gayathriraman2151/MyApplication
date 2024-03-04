namespace WebRestfulAPI.Model
{
    public interface IRepository
    {
        // Returns a found article or null.
        public Article? Get(Guid Id);

        // Creates a new article and returns its identifier.
        // Throws an exception if a article is null.
        // Throws an exception if a title is null or empty.
        public Guid Create(Article article);

        // Returns true if an article was deleted or false if it was not possible to find it.
        public bool Delete(Guid Id);
        
        // Returns true if an article was updated or false if it was not possible to find it.
        // Throws an exception if an articleToUpdate is null.
        // Throws an exception or if a title is null or empty.
        public bool Update(Article articleToUpdate);

    }
}
