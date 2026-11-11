namespace DevUniverse.Api.Models;

public class Developer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email {get; set; } = "";
    public string Level { get; set; } = "";         // ④ FILTER   → level to match/change
    public List<string> Skills { get; set; } = new(); // ⑤ NESTED  → developer's skills
  
    
    
}

