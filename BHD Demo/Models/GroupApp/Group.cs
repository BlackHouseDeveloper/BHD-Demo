namespace BHD_Demo.Models.GroupApp
{
    public class Group
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
        public List<string> Members { get; set; } = new List<string>();

        // Optional: Constructor for easy initialization
        public Group(string groupName, string description)
        {
            GroupName = groupName;
            Description = description;
        }
    }
}
