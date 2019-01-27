using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasAEx1
{
    class TV   
    {
        public bool power;
        public int channel;

        public void TurnOnPower()
        {
            power = !power; //스위치 역할
        }
        public void ChangeChannel(int channel)
        {
            this.channel = channel;
        }
        public void WatchingTV()
        {
            Console.WriteLine("보글보글 스폰지밥~~~~~~");
        }
    }
    class VCR
    {
        public bool power = false;

        public void PlayVideo()
        {
            Console.WriteLine("비디오 플레이~~~");
        }
        public  void StopVideo()
        {
            Console.WriteLine("비디오 정지");
        }
    }

    class TVCR : TV // TV는 상속관계로 만든다.; 그럼 TV와 VCR은 서로 아무 관계가 아니다 그저 각각의 객체일뿐
      // TVCR은 TV와 VCR의 역할을 모두 가져야 한다. 하지만 다중 상속은 불가능하다. 그래서0 하나는 상속을 시키고 하나는 멤버(포함)관계를 만든다.
    {
        VCR vcr = new VCR();    // VCR은 멤버(포함)관계 로 만든다.

        public void PlayVideo() // 상속관계가 아니기 때문에 굳이 new를 사용하지 않아도 된다.
        {
            vcr.PlayVideo();
        }
        public void StopVideo()
        {
            vcr.StopVideo();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TVCR tvcr = new TVCR();
            tvcr.WatchingTV();  // 상속시킨 TV에 있는 것
            tvcr.PlayVideo();   // 멤버 관계로 만든것
        }
    }
}
