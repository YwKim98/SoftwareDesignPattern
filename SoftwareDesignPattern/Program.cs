class Program
{
    static void Main(string[] args)
    {
        // 싱글톤 패턴
        Console.WriteLine("[싱글톤 패턴]");
        var singleton = SingletonPattern.Singleton.Instance;
        singleton.SomeBusinessLogic(); // 싱글톤 클래스의 메소드 호출
        

        // 옵저버 패턴
        Console.WriteLine("[옵저버 패턴]");
        var subject = new ObserverPattern.Subject(); // 주체 생성
        var observer = new ObserverPattern.Observer(subject); // 옵저버 생성 및 주체에 등록

        Console.Write("숫자를 입력하세요: "); // 사용자로부터 숫자 입력 받음
        int data = int.Parse(Console.ReadLine());

        subject.Data = data; // 주체의 데이터를 사용자가 입력한 숫자로 변경

        Console.Write("숫자를 입력하세요: "); // 사용자로부터 숫자 입력 받음
        data = int.Parse(Console.ReadLine());

        subject.Data = data; // 주체의 데이터를 사용자가 입력한 숫자로 변경
    }
}
