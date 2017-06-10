using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class PostModel
{
    public ObjectId _id { get; set; }
    [BsonRequired]
    public string dbid {get; set;}
    public string Company { get; set; }
    public string Posts { get; set; }
	public string Username { get; set; }
	public string Password { get; set; }
}