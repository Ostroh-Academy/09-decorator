Console.OutputEncoding = System.Text.Encoding.UTF8;

IButton simpleButton = new SimpleButton("Click me");

// Додаємо до неї іконку та відображаємо.
IButton buttonWithIcon = new IconDecorator(simpleButton, "⭐");
buttonWithIcon.Render();

// Додаємо до кнопки похилий шрифт та відображаємо.
IButton buttonWithItalicFont = new ItalicFontDecorator(simpleButton);
buttonWithItalicFont.Render();

// Додаємо до кнопки зміну коліру фону та відображаємо.
IButton buttonWithBackgroundColor = new BackgroundColorDecorator(simpleButton);
buttonWithBackgroundColor.Render();