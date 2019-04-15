for /l %%x in (1, 1, 100) do (
   echo //updated >> sw-keepalive.js
   timeout 25
)
pause