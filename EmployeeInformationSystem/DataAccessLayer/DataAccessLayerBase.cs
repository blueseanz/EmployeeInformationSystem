namespace DataAccessLayer
{
    public class DataAccessLayerBase
    {
        protected EISDBContext db;

        public DataAccessLayerBase()
        {
            db = new EISDBContext();
        }
    }
}
