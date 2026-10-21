using System;

namespace FFXIVPVPAuto.Verification;

internal static class TestCodeServerOptions
{
	internal const string BaseUrl = "http://43.155.216.98";

	internal const string ServerEncryptionKeyId = "pvpa-encryption-v1";

	internal const string ServerSigningKeyId = "pvpa-signing-v1";

	internal const string ServerEncryptionPublicKey = "-----BEGIN PUBLIC KEY-----\nMIIBojANBgkqhkiG9w0BAQEFAAOCAY8AMIIBigKCAYEArzmEMYbMS33z2jSlcSUq\nv/DOcjBdn6YrSH6HxmH2yQGnBq9+K9+r68xC4dcI4uOCCHzCKoohNOaMuXf35xm+\n53VJI2BdEdAUFU0gSvO2PN+LFXeJZLxm/yb9SGjqxiKsDZMna80FLcsOshQ6qmBR\nU08Dj85bvQWJF6xN41y8TzM/Z4HPC0k2DratcdnyxbbuiG2m7jpbIrtq+4X6fBhF\nDieLG5j2lIGK/u96iYo+DN7tgMjRk1QbdEsA4K/n87wcVW93UAWwtgNHRHWy8iEn\nxXiCY3pPpJK8y0G/rahMCzOS1rg4lVehBiUKNxtIMeQML8rYlfY1X8B+JqcOcBai\nhlPLLOM+qHJXF+0MpYThZHAYCx77TFA9+ZwJag9KSpEZ0TE0hZqI8x7DMmdGnGFd\nGfl4h0HMUELP+dfNWal4kd3fQPvsfHmywu8TxdqHTKuV7kCKgnIqvrhai59ybod1\nAnTS9b3UyXaz+nvoDBKLrXoAvlBk7lxuRvhYzyCSTaMdAgMBAAE=\n-----END PUBLIC KEY-----";

	internal const string ServerSigningPublicKey = "-----BEGIN PUBLIC KEY-----\nMIIBojANBgkqhkiG9w0BAQEFAAOCAY8AMIIBigKCAYEAtz9yz50SV7WTU916sh08\n0FrBxKMw/YluKdhUHw5e/z1iiJHENZ2gPvFX5igmLe8zLiUJEASymccU7L6XQ6Ml\nMcd5OpEN6hhZ8KD0NEPXQMrYt7BWon3gHcH7cjwoZd9C8S/JHhIXyXtTenmBA2ux\nybcx/PX4xkLPOgiZO+roVOExj9pN16QzHDv8lQwjyF7xAuri06VZX0I0Z0j0FGRB\ndTPyYbh40jOO1fUwUcp1ppRpFn+LdY/6dNKif1qrGXc3Oh3UHgjqCb3WHorj7wt+\nABsax0Zio2nWV/LTrMvSFVqxrH6p1BIgUG85Tr0anPh2FLrGq7PiWt33qqz2iYe3\nhHAN8dDW08TO6Z2t1m4V38GilwolwH32k3lFvKoviyjOdv1++Ik0u5RK1gCQPq0F\nmdEhddtjYmsm0VDVekMJJ7yucZQm5sUmzFHtXDpQ5hWLA4U7284UmRLKjBtnklDu\nhITABon8ZlVlEvaMDqvTxYQXwO9uGEU+fvXaW6XF0FapAgMBAAE=\n-----END PUBLIC KEY-----";

	internal const string RequestPath = "/api/v1/test-code/request";

	internal const string StatusPath = "/api/v1/test-code/status";

	internal const int PluginId = 1006;

	internal static readonly TimeSpan RequestTimeout;

	internal static readonly TimeSpan SchedulerInterval;

	internal static readonly TimeSpan TransientRetryDelay;

	internal static bool IsConfigured
	{
		get
		{
			//Invalid MethodBodyBlock: Invalid method header: 0xB0
		}
	}

	static TestCodeServerOptions()
	{
		//Invalid MethodBodyBlock: Invalid method header: 0x9F 0xD8
	}
}
