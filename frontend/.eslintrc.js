module.exports = {
  env: {
    browser: true,
    node: true,
    es6: true
  },
  extends: [
    'plugin:@angular-eslint/recommended',
    'plugin:@typescript-eslint/recommended',
    'plugin:@typescript-eslint/recommended-requiring-type-checking'
  ],
  parser: '@typescript-eslint/parser',
  parserOptions: {
    project: 'tsconfig.json',
    sourceType: 'module'
  },
  plugins: [
    '@typescript-eslint'
  ],
  rules: {
    'indent': ['error', 2],
    '@angular-eslint/directive-selector': ['error', { type:   'attribute', prefix: 'ourprefix', style: 'camelCase'}],
    '@angular-eslint/component-selector': ['error', { type: 'element', prefix: 'ourcomponent', style: 'kebab-case'}]
  }
};
