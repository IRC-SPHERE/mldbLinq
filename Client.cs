namespace mldbLinq
{
    using Shaolinq;
    using Shaolinq.Postgres;
    
    public class Client
    {
        public string ConnectionString { get; set; } =
            "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        public void Connect()
        {
            var configuration = PostgresConfiguration.Create(ConnectionString);
            var model = DataAccessModel.BuildDataAccessModel<MldbModel>(configuration);
        }
    }

    [DataAccessModel]
    public abstract class MldbModel : DataAccessModel
    {
        [DataAccessObjects]
        public abstract DataAccessObjects<>
    }
}