﻿using Ardalis.Specification;

namespace HolaMundoCompleto.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
