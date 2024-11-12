/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml'
  ],
  theme: {
      extend: {
          borderRadius: {
              "2xl": "2rem"
          }
      },
  },
  plugins: [],
}

