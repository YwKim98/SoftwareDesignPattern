namespace SingletonPattern
{
    // Singleton 클래스: 싱글톤 패턴을 구현한 클래스
    public class Singleton
    {
        // _instance: 클래스의 유일한 인스턴스를 저장하는 정적 필드
        private static Singleton _instance;

        // _lock: 멀티스레드 환경에서 동기화를 위한 객체
        private static readonly object _lock = new object();

        // 생성자는 private으로 선언하여 클래스 외부에서 직접 인스턴스를 생성하지 못하도록 함
        private Singleton()
        {
        }

        // Instance: 유일한 인스턴스에 접근하기 위한 정적 속성
        public static Singleton Instance
        {
            get
            {
                // 멀티스레드 환경에서도 인스턴스가 한 번만 생성되도록 lock 키워드를 사용해 동기화함
                lock (_lock)
                {
                    // 인스턴스가 아직 생성되지 않았다면 새 인스턴스를 생성
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    // 생성된 인스턴스를 반환
                    return _instance;
                }
            }
        }

        // SomeBusinessLogic: 싱글톤 인스턴스에서 수행할 비즈니스 로직을 구현한 메소드
        public void SomeBusinessLogic()
        {
            // 실제 비즈니스 로직 구현
            Console.WriteLine("싱글톤 인스턴스 생성 및 인스턴스 메소드 호출\n");
        }
    }
}

