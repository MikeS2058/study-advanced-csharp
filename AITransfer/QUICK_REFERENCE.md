# AITransfer Quick Reference

## What Is This?

A collection of AI configuration templates and coding standards for C# / .NET projects that can be copied to new repositories.

## Quick Start (3 Steps)

### 1. Copy AITransfer folder to your new repository root

### 2. Run Setup Command (PowerShell)

```powershell
New-Item -ItemType Directory -Path ".github" -Force; New-Item -ItemType Directory -Path ".junie" -Force; Copy-Item -Path "AITransfer\copilot-instructions.md" -Destination ".github\copilot-instructions.md" -Force; Copy-Item -Path "AITransfer\global-copilot-instructions.md" -Destination ".github\global-copilot-instructions.md" -Force; Copy-Item -Path "AITransfer\junie-guidelines.md" -Destination ".junie\guidelines.md" -Force; Copy-Item -Path "AITransfer\.editorconfig" -Destination ".editorconfig" -Force; Copy-Item -Path "AITransfer\.gitignore" -Destination ".gitignore" -Force; Copy-Item -Path "AITransfer\.gitattributes" -Destination ".gitattributes" -Force; Copy-Item -Path "AITransfer\global.json" -Destination "global.json" -Force
```

### 2b. Fix BOM in global.json (REQUIRED!)

⚠️ **CRITICAL**: The copied `global.json` has a BOM that breaks .NET CLI. Fix it immediately:

```powershell
Remove-Item -Path "global.json" -Force; @"
{
  "sdk": {
    "version": "10.0.100",
    "rollForward": "latestPatch"
  }
}
"@ | Out-File -FilePath "global.json" -Encoding utf8NoBOM
```

Replace `10.0.100` with your SDK version. See `BOM_ENCODING_NOTE.md` for details.

### 3. Customize Files (REQUIRED!)

Open `CUSTOMIZATION_CHECKLIST.md` and work through each item.

**Critical placeholders to replace**:
- `[PROJECT_NAME]`
- `[ProjectFolder]`
- `[TestFolder]`
- `[SolutionName]`
- `[version]`
- All others marked with `[...]`

## Files Overview

| File | Destination | Purpose |
|------|-------------|---------|
| copilot-instructions.md | `.github/` | GitHub Copilot coding standards |
| global-copilot-instructions.md | `.github/` | General app dev guidelines |
| junie-guidelines.md | `.junie/` | Junie AI assistant config |
| .editorconfig | Root | Code formatting rules |
| .gitignore | Root | Git ignore patterns |
| .gitattributes | Root | Git line ending config |
| global.json | Root | .NET SDK version |

## Supported Project Types

✅ Console Applications  
✅ Class Libraries  
✅ Web Applications (ASP.NET Core, Blazor)  
✅ Desktop Apps (WPF, WinForms, MAUI)  
✅ Azure Functions  
✅ Worker Services  
✅ Test Projects  

## Documentation Files

- **README.md** — Overview and detailed usage instructions
- **SETUP_GUIDE.md** — Step-by-step PowerShell commands
- **CUSTOMIZATION_CHECKLIST.md** — Complete checklist for customizing templates
- **QUICK_REFERENCE.md** — This file!

## Common Mistakes to Avoid

❌ Forgetting to replace `[PROJECT_NAME]` placeholders  
❌ Leaving version numbers as `[version]`  
❌ Not updating global.json SDK version  
❌ Not adjusting .editorconfig for team preferences  
❌ Copying files without customizing them  
❌ Using Bash commands (`&&`) instead of PowerShell (`;`)  
❌ **Not fixing BOM in global.json - causes .NET CLI errors!**  
❌ **Creating JSON files with BOM encoding**

## Creating GitHub Repository (Step 4)

After setup and customization, push to GitHub:

### Option 1: Automated Script (Easiest)

Copy `Setup-GitHubRemote.ps1` from the example repository and run:

```powershell
.\Setup-GitHubRemote.ps1
```

The script will:
- Check git status
- Create GitHub repository (using gh CLI)
- Add remote and push code
- Open in browser

### Option 2: GitHub CLI (Fast)

```powershell
# Authenticate (first time only)
gh auth login

# Create and push
gh repo create YOUR_REPO_NAME --public --source=. --remote=origin --description "Your description"
git push -u origin main
```

### Option 3: Manual

1. Create repo at https://github.com/new
2. Don't initialize with any files
3. Run:
```powershell
git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git
git push -u origin main
```

See `SETUP_GUIDE.md` for detailed instructions and troubleshooting.  

## Verification Commands

After setup and customization:

```powershell
# Verify files copied
Get-ChildItem -Path ".github" -Force
Get-ChildItem -Path ".junie" -Force

# Test build
dotnet build YourSolution.sln

# Run tests
dotnet test YourSolution.sln
```

## Need Help?

1. Read **README.md** for comprehensive overview
2. Follow **SETUP_GUIDE.md** for detailed steps
3. Use **CUSTOMIZATION_CHECKLIST.md** to ensure nothing is missed
4. Review template files for inline comments and guidance

## Update Schedule

Review and update these files when:
- Upgrading .NET SDK versions
- Changing project structure
- Updating team coding standards
- Adding new projects to solution

## 🔄 Maintaining Template Synchronization (Important!)

**If this repository's AI instructions evolve, update AITransfer templates too!**

When you modify files in `.github/`, `.junie/`, or root config files in the source repository, you **must sync** the corresponding template files in `AITransfer/`:

1. Copy updated file to AITransfer
2. Replace project-specific values with placeholders (e.g., `ProjectName` → `[PROJECT_NAME]`)
3. Keep patterns, standards, and best practices intact
4. Commit both active and template files together

**Why?** AITransfer is copied to new repos. Outdated templates mean new projects start with old standards.

See `INDEX.md` section "🔄 Maintaining AITransfer Files" for detailed workflow.

---

**Version**: 1.0  
**Last Updated**: December 2, 2025