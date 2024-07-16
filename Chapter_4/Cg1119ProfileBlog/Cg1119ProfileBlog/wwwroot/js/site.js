//Color Theme

var changeButton;
var themeIcon;
var htmlElement;

const lightIcon = "bi-brightness-high-fill";
const darkIcon = "bi-moon-fill";

function changeThemeIcon() {
    let isThemeDark = localStorage.getItem('theme') === "dark";
    if (isThemeDark) {
        themeIcon.classList.remove(darkIcon);
        themeIcon.classList.add(lightIcon);
    }
    else {
        themeIcon.classList.remove(lightIcon);
        themeIcon.classList.add(darkIcon);
    }

    htmlElement.setAttribute('data-bs-theme', isThemeDark ? 'dark' : 'light');
}

document.addEventListener('DOMContentLoaded',
    () => {
        changeButton = document.getElementById('themeChange');
        themeIcon = document.getElementById('theme-icon');
        htmlElement = document.documentElement;
        changeThemeIcon();

    changeButton.addEventListener('click', () => {
        let theme = htmlElement.getAttribute('data-bs-theme');

        if (theme === 'light') localStorage.setItem('theme', 'dark');
        else localStorage.setItem('theme', 'light');

        changeThemeIcon(localStorage.getItem('theme'));
    });
});

// 로그아웃
function logout(event){
    event.preventDefault();
    if (confirm('정말 로그아웃 하시겠습니까?')) {
        document.getElementById('logout').submit();
    }
}