using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
			struct hostent hp;
			struct sockaddr_in sin;
			int s;
			string request = "message";


			bzero((char*)&sin, sizeof(sin));
			sin.sin_family = AF_INET;
			bcopy(hp->h_addr, (char*)&sin.sin_addr, hp->h_length);
			sin.sin_port = htons(SERVER_PORT);


			if ((s = socket(PF_INET, SOCK_STREAM, 0)) < 0)
			{
				return;
			}
			if (connect(s, (struct sockaddr *)&sin, sizeof(sin)) < 0)
				{
				close(s);
				return;
			}
			request = "message";
			if (send(s, request, 48, 0) < 0)
			{
				return;
			}

			close(s);
        }
    }
}