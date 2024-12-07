using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

/*

Для валидации данных используйте атрибуты из пространства имен System.ComponentModel.DataAnnotations. Например, для проверки обязательных полей, применяйте атрибут [Required].
Модель должна содержать методы, инкапсулирующие бизнес-логику, связанную с каждой сущностью
Свойства классов должны быть реализованы с использованием
доступа public, однако, рекомендуется использовать приватные
сеттеры для предотвращения изменения состояния объекта вне
модели.
Определите интерфейсы для моделей, чтобы повысить тестируемость
и позволить реализовывать различные версии моделей. 
Если модель используется в привязке данных, она должна
реализовывать интерфейс INotifyPropertyChanged, чтобы
уведомлять представление об изменениях в данных.

дополнительные (на пятерку)
Модель должна поддерживать сериализацию в формат JSON для взаимодействия с API или хранения данных. Рассмотрите использование атрибутов из Newtonsoft.Json или System.Text.Json.
Код модели должен быть легко тестируемым. Напишите юнит-тесты для проверки бизнес-логики и валидации данных.
 Все классы и методы должны быть задокументированы с помощью XML-комментариев, описывающих назначения и параметры методов.


ответ предоставляется в виде ссылки на репозиторий  

репозиторий должен быть публичным
в репозитории так же должен лежать sql скрипт
*/