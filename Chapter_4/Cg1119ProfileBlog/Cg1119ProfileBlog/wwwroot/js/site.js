﻿// 다크모드
document.addEventListener('DOMContentLoaded', () => {
    let changeButton = document.getElementById('themeChange');
    let htmlElement = document.documentElement;

    let lightIcon = `
        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-sun" viewBox="0 0 16 16">
            <path d="M8 11a3 3 0 1 1 0-6 3 3 0 0 1 0 6m0 1a4 4 0 1 0 0-8 4 4 0 0 0 0 8M8 0a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-1 0v-2A.5.5 0 0 1 8 0m0 13a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-1 0v-2A.5.5 0 0 1 8 13m8-5a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1 0-1h2a.5.5 0 0 1 .5.5M3 8a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1 0-1h2A.5.5 0 0 1 3 8m10.657-5.657a.5.5 0 0 1 0 .707l-1.414 1.415a.5.5 0 1 1-.707-.708l1.414-1.414a.5.5 0 0 1 .707 0m-9.193 9.193a.5.5 0 0 1 0 .707L3.05 13.657a.5.5 0 0 1-.707-.707l1.414-1.414a.5.5 0 0 1 .707 0m9.193 2.121a.5.5 0 0 1-.707 0l-1.414-1.414a.5.5 0 0 1 .707-.707l1.414 1.414a.5.5 0 0 1 0 .707M4.464 4.465a.5.5 0 0 1-.707 0L2.343 3.05a.5.5 0 1 1 .707-.707l1.414 1.414a.5.5 0 0 1 0 .708"/>
        </svg>`;

    let darkIcon = `
        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-moon-fill" viewBox="0 0 16 16">
            <path d="M6 .278a.77.77 0 0 1 .08.858 7.2 7.2 0 0 0-.878 3.46c0 4.021 3.278 7.277 7.318 7.277q.792-.001 1.533-.16a.79.79 0 0 1 .81.316.73.73 0 0 1-.031.893A8.35 8.35 0 0 1 8.344 16C3.734 16 0 12.286 0 7.71 0 4.266 2.114 1.312 5.124.06A.75.75 0 0 1 6 .278" />
        </svg>`;

    let currentTheme = localStorage.getItem('theme');
    if (currentTheme) {
        htmlElement.setAttribute('data-bs-theme', currentTheme);
        changeButton.innerHTML = currentTheme === 'dark' ? lightIcon : darkIcon;
    } else {
        htmlElement.setAttribute('data-bs-theme', 'light');
        changeButton.innerHTML = darkIcon;
    }

    changeButton.addEventListener('click', () => {
        let theme = htmlElement.getAttribute('data-bs-theme');

        if (theme === 'light') {
            htmlElement.setAttribute('data-bs-theme', 'dark');
            changeButton.innerHTML = lightIcon;
            localStorage.setItem('theme', 'dark');
        }
        else {
            htmlElement.setAttribute('data-bs-theme', 'light');
            changeButton.innerHTML = darkIcon;
            localStorage.setItem('theme', 'light');
        }
    });
});

// 로그아웃 버튼

document.getElementById('logoutButton').addEventListener('click', function (event) {
    event.preventDefault();
    if (confirm('정말 로그아웃 하시겠습니까?')) {
        document.getElementById('logout').submit();
    }
});