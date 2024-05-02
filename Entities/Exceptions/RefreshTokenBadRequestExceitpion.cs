namespace Entities.Exceptions
{
    public class RefreshTokenBadRequestExceitpion : BadRequestException
    {
        public RefreshTokenBadRequestExceitpion() : base($"Invalid client request. The tokenDto has some invalid values.")
        {

        }
    }
}
