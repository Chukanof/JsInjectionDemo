# Запросы:
- `/api/values/count?value=1`
  - Эталонный запрос
- `/api/values/count?value=1&abc<script>alert(1)</script>def=1`
  - Отрабатывает корректно, js не выполняется
- `/api/values/count?abc<script>alert(1)</script>def=1`
  - роут не находится, скрипт выполняется