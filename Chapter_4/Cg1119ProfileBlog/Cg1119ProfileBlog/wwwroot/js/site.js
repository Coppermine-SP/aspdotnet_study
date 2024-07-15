﻿// 다크모드
document.addEventListener('DOMContentLoaded', () => {
    let changeButton = document.getElementById('themeChange');
    let htmlElement = document.documentElement;

    let currentTheme = localStorage.getItem('theme');
    if (currentTheme) {
        htmlElement.setAttribute('data-bs-theme', currentTheme);
        if (currentTheme === 'dark') {
            changeButton.textContent = '라이트모드';
        } else {
            changeButton.textContent = '다크모드';
        }
    }

    changeButton.addEventListener('click', () => {
        let theme = htmlElement.getAttribute('data-bs-theme');

        if (theme === 'light') {
            htmlElement.setAttribute('data-bs-theme', 'dark');
            changeButton.textContent = '라이트모드';
            localStorage.setItem('theme', 'dark');
        }
        else {
            htmlElement.setAttribute('data-bs-theme', 'light');
            changeButton.textContent = '다크모드';
            localStorage.setItem('theme', 'light');
        }
    });
});

// 로그인, 아웃 버튼

function logout() {
    
}