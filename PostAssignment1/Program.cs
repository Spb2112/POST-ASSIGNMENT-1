using PostAssignment1;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

var databaseconnect = new PostContext();
var user1 = new User();
var user2 = new User();
var blogType = new BlogType();
var postType = new PostType();
var blog = new Blog();
List<User> users;
List<Blog> blogs;
List<PostType> postTypes;
List<Post> Posts;
var newPost = new Post();

user1.Name = "Sourav";
user1.EmailAddress = "Sourav@gmail.com";
user1.PhoneNumber = "987-654-321";

user2.Name = "Prachi";
user2.EmailAddress = "Prachi@gmail.com";
user2.PhoneNumber = "123-789-698";

databaseconnect.Users.Add(user1);
databaseconnect.Users.Add(user2);
databaseconnect.SaveChanges();

blogType.Name = "Song";
blogType.Description = "song Description";

postType.Name = "Trending song";
postType.Description = "Trending song Description";
postType.Status = "Active";

databaseconnect.BlogTypes.Add(blogType);
databaseconnect.PostTypes.Add(postType);
databaseconnect.SaveChanges();

blog.Url = "http://example.com";
blog.IsPublic = true;
blog.BlogTypeId = blogType.Id;

databaseconnect.Blogs.Add(blog);
databaseconnect.SaveChanges();

users = databaseconnect.Users.ToList();
blogs = databaseconnect.Blogs.ToList();
postTypes = databaseconnect.PostTypes.ToList();

var UserId = users.First().Id;
var BlogId = blogs.First().Id;
var postTypeId = postTypes.First().Id;

newPost.Title = "Post Title";
newPost.Content = "This is the content";
newPost.UserId = UserId;
newPost.BlogId = BlogId;
newPost.PostTypeId = postTypeId;


databaseconnect.Posts.Add(newPost);
databaseconnect.SaveChanges();

Posts = databaseconnect.Posts.ToList();
Console.WriteLine("User Details");
foreach (var u in users)
{
    Console.WriteLine($"ID : {u.Id},Name : {u.Name},  Email Address : {u.EmailAddress}, Phone Number : {u.PhoneNumber},");
}
Console.WriteLine("");
Console.WriteLine("Post Details");
foreach (var p in Posts)
{
    Console.WriteLine($"ID : {p.Id},Title : {p.Title},  Content : {p.Content}, User Name : {p.User.Name}, Post Type Name : {p.PostType.Name}, ");
}

