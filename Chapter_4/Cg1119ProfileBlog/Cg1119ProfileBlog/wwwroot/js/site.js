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
// 로그인 확인
function login(event) {
    event.preventDefault();
    if(confirm('로그인 이후 사용 가능한 기능입니다. 로그인 하시겠습니까?')) {
        window.location.href = event.currentTarget.href;
    }
}
// 로그아웃
function logout(event){
    event.preventDefault();
    if (confirm('정말 로그아웃 하시겠습니까?')) {
        document.getElementById('logout').submit();
    }
}