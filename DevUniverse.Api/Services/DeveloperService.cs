using DevUniverse.Api.Models;  // Makes the Developer type available
using DevUniverse.Api.Results;


public class DeveloperService : IDeveloperService
{
    private static readonly List<Developer> _developers = new();


     // ═══════════ READ — FETCH DATA ═══════════
    public List<Developer> GetAll(string? level)
    {
        // Implementation for fetching all developers
    }
    public Developer? GetById(int id)
    {
        Developer? foundDeveloper =  _developers.Find(d => d.Id == id);
       
        return foundDeveloper;

    }


    public List<string>? GetDeveloperSkill(int id)
    {
        // Implementation for fetching a developer's skills by ID
    }



    // ═══════════ CHANGE — MODIFY DATA ════════

    public int? Create(CreateDeveloperDto dto)
    {
        // Implementation for creating a new developer  
    }
    public bool Delete(int id)
    {
       Developer? developer =  _developers.Find(d => d.Id == id);

       if(developer == null)
        {
            return false;
        }

        _developers.Remove(developer);

        return true;

    }


    public UpdateResult Update(int id, ReplaceDeveloperDto dto)
    {
        // Implementation for updating a developer by ID
    }
    public PatchResult Patch(int id, PatchDeveloperDto dto)
    {
        // Implementation for patching a developer by ID
    }


}
