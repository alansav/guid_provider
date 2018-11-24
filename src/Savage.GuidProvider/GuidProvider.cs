using System;

namespace Savage.GuidProvider
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
