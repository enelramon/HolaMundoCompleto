using Ardalis.Result;

namespace HolaMundoCompleto.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(int contributorId);
}
