using System;

namespace Ahnenforscherin.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
