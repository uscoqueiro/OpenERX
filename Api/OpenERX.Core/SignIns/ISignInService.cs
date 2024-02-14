using OpenERX.Commons.Results;

namespace OpenERX.Core.SignIns;

public interface ISignInService: IResultService
{
    Task<SignInResult> SignInAsync(SignInParams @params);
}