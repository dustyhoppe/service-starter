namespace ServiceStarter.Domain.Handlers
{
    public enum FailureReasonType
    {
        None,
        ValidationErrors,
        MissingRequiredPolicy,
        NotAuthenticated,
        EntityNotFound,
        ConcurrencyException
    }
}
