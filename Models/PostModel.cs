using MongoDB.Bson;

public class PostModel
{
    public ObjectId _id { get; set; }
    public string company { get; set; }
    public string posts { get; set; }
	public string username { get; set; }
	public string password { get; set; }
}