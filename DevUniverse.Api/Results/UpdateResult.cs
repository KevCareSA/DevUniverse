namespace DevUniverse.Api.Results;

public enum UpdateResult
{
    Updated,        // ① Developer successfully updated
    NotFound,       // ② Developer does not exist
    EmailConflict   // ③ Email already belongs to another developer
}
