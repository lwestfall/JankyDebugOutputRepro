# Repro sample for janky debug output in VSCode

See: <https://github.com/microsoft/vscode/issues/107704>

## Steps to reproduce issue

    1. Open Terminal tab.
    2. Launch debugger.
    3. Wait ~15+ seconds **before opening debug console** to allow the debug output to get some log messages.
        - Note: It seems like there needs to be some minimum count of messages before the issue appears, hence the recommended wait time.
    4. Go to debug console. Try to scroll up.
    5. Keep trying to scroll up.
    6. Repeat steps 3-4 until angry.
    7. If scrolling seems fine, try:
       1. Switch to terminal
       2. Switch back to debug console
       3. Try scrolling up

launch.json not gitignored just in case it matters to the issue (it is default launch config though).
