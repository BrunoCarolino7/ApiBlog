namespace Blog.Models;

public class Role
{

    private List<string> notification;

    public Role(int id, string name, string slug, IList<User> users)
    {
        Id = id;
        Name = name;
        Slug = slug;
        Users = users;

        if (string.IsNullOrEmpty(name))
        {
            notification.Add("erro");
        }

    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }

    public IList<User> Users { get; set; }




}