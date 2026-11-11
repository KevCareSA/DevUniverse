using DevUniverse.Api.Models;  // Makes the Developer type available
using DevUniverse.Api.Results;

public interface IDeveloperService
{
    // ═══════════ READ — FETCH DATA ═══════════
    List<Developer> GetAll(string? level);
    Developer? GetById(int id);
    List<string>? GetDeveloperSkill(int id);



    // ═══════════ CHANGE — MODIFY DATA ════════

    int? Create(CreateDeveloperDto dto);
    bool Delete(int id);
    UpdateResult Update(int id, ReplaceDeveloperDto dto);
    PatchResult Patch(int id, PatchDeveloperDto dto);
}
