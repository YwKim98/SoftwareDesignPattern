namespace ObserverPattern
{
    // Subject 클래스: 옵저버 패턴에서 관찰 대상이 될 주체를 정의한 클래스
    public class Subject
    {
        // _observers: 주체를 관찰하는 옵저버들의 목록
        private List<Observer> _observers = new List<Observer>();

        // _data: 주체의 상태를 나타내는 데이터
        private int _data;

        // Data: 주체의 상태를 get/set할 수 있는 속성
        public int Data
        {
            get { return _data; }
            set
            {
                _data = value; // 데이터 변경
                NotifyObservers(); // 모든 옵저버에게 알림
            }
        }

        // Attach: 옵저버를 목록에 추가하는 메소드
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        // Detach: 옵저버를 목록에서 제거하는 메소드
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        // NotifyObservers: 모든 옵저버에게 상태 변경을 알리는 메소드
        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }

    // Observer 클래스: 옵저버 패턴에서 주체의 상태를 관찰하는 옵저버를 정의한 클래스
    public class Observer
    {
        // _subject: 관찰 대상인 주체
        private Subject _subject;

        // Observer: 주체를 인자로 받아 이를 관찰 대상으로 설정하고, 옵저버를 주체에 등록하는 생성자
        public Observer(Subject subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        // Update: 주체의 상태가 변경되었음을 알리는 메소드
        public void Update()
        {
            Console.WriteLine($"Observer: 주체의 데이터가 {_subject.Data}로 변경되었습니다.");
        }
    }
}
