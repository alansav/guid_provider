using System;

namespace Savage.Providers
{
    public interface IGuidProvider
    {
        Guid NewGuid();
    }

    public class GuidProvider : IGuidProvider
    {
        public Guid NewGuid()
        {
            return Guid.NewGuid();
        }
    }
}
