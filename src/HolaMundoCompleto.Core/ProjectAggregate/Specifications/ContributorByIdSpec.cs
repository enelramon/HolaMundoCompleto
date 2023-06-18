using Ardalis.Specification;
using HolaMundoCompleto.Core.ContributorAggregate;

namespace HolaMundoCompleto.Core.ProjectAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
