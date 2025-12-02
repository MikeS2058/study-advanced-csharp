# AITransfer Directory

This directory contains AI-related configuration files and coding standards that can be copied to new C# / .NET repositories. These files help maintain consistent AI assistant behavior, code quality, and development practices across projects.

## Files Included

### GitHub Copilot Configuration
- **copilot-instructions.md** — Main GitHub Copilot instructions template for C# / .NET projects
  - Provides coding standards, build commands, and best practices
  - **Customization required**: Update project names, namespaces, and specific requirements
  
- **global-copilot-instructions.md** — Global Copilot instructions template for general app development
  - Framework-agnostic development guidelines
  - Mission canvas, architecture patterns, and operational standards
  
- **CSharpStudies.md** — C# learning and lesson planning template
  - Useful for educational or training projects
  - Can be adapted for documenting C# feature usage

### AI Assistant Configuration
- **junie-guidelines.md** — Generic guidelines template for Junie AI assistant
  - Covers project overview, testing, build instructions, and code style
  - **Customization required**: Update project names, frameworks, and specific conventions

### Code Style & Standards
- **.editorconfig** — Editor configuration for code formatting and style rules
  - Enforces consistent C# coding standards
  - Includes rules for `this.` qualifiers, file-scoped namespaces, one type per file
  - **Review and adjust** based on team preferences

- **.gitignore** — Git ignore patterns for .NET projects
  - Standard Visual Studio and .NET build artifacts
  - **Extend as needed** for project-specific files

- **.gitattributes** — Git attributes for line endings and file handling
  - Ensures consistent line endings across platforms

### Project Configuration
- **global.json** — .NET SDK version specification template
  - **Update required**: Set appropriate SDK version for your project

## How to Use

### 1. Copy Files to New Repository

Use the commands in `SETUP_GUIDE.md` or manually copy files:

```powershell
# From new repository root (after placing AITransfer folder)
New-Item -ItemType Directory -Path ".github" -Force
New-Item -ItemType Directory -Path ".junie" -Force

Copy-Item -Path "AITransfer\copilot-instructions.md" -Destination ".github\copilot-instructions.md" -Force
Copy-Item -Path "AITransfer\global-copilot-instructions.md" -Destination ".github\global-copilot-instructions.md" -Force
Copy-Item -Path "AITransfer\junie-guidelines.md" -Destination ".junie\guidelines.md" -Force
Copy-Item -Path "AITransfer\.editorconfig" -Destination ".editorconfig" -Force
Copy-Item -Path "AITransfer\.gitignore" -Destination ".gitignore" -Force
Copy-Item -Path "AITransfer\.gitattributes" -Destination ".gitattributes" -Force
Copy-Item -Path "AITransfer\global.json" -Destination "global.json" -Force
```

### 2. Customize for Your Project

**Critical**: These are templates. You must customize them for each project.

**⚠️ IMPORTANT: Fix BOM Encoding in global.json**  
After copying, the `global.json` file will contain a BOM (Byte Order Mark) that causes .NET CLI errors. You **must** recreate it without BOM:

```powershell
Remove-Item -Path "global.json" -Force
@"
{
  "sdk": {
    "version": "10.0.100",
    "rollForward": "latestPatch"
  }
}
"@ | Out-File -FilePath "global.json" -Encoding utf8NoBOM
```

Replace `10.0.100` with your actual SDK version. See `BOM_ENCODING_NOTE.md` for details.

**General Rule**: Always create JSON files with UTF-8 without BOM encoding to avoid parsing errors.

#### copilot-instructions.md
- Replace `[PROJECT_NAME]` with your actual project name
- Replace `[ProjectFolder]`, `[TestFolder]` with actual folder names
- Update `[SolutionName]`, `[version]` placeholders
- Adjust coding patterns to match your project type (console, web, library, etc.)
- Remove sections that don't apply (e.g., extension methods if not used)

#### junie-guidelines.md
- Update `[DATE]` with current date
- Replace `[ProjectName]`, `[TestProjectName]` with actual names
- Specify test framework and assertion libraries
- Add project-specific requirements

#### global.json
- Set actual .NET SDK version required for your project
- **Always use UTF-8 without BOM encoding**

#### .editorconfig
- Review and adjust style rules based on team preferences
- Add project-specific formatting rules

#### .gitignore
- Add project-specific ignore patterns
- Remove unnecessary entries

### 3. File Locations in Target Repository

| Source File | Destination | Required |
|------------|-------------|----------|
| copilot-instructions.md | `.github/copilot-instructions.md` | Recommended |
| global-copilot-instructions.md | `.github/global-copilot-instructions.md` | Optional |
| CSharpStudies.md | `.github/CSharpStudies.md` | Optional |
| junie-guidelines.md | `.junie/guidelines.md` | If using Junie |
| .editorconfig | `.editorconfig` | Recommended |
| .gitignore | `.gitignore` | Recommended |
| .gitattributes | `.gitattributes` | Recommended |
| global.json | `global.json` | Required for .NET |

## Project Type Compatibility

These templates work with various C# / .NET project types:

- ✅ Console Applications
- ✅ Class Libraries
- ✅ Web Applications (ASP.NET Core, Blazor, etc.)
- ✅ Desktop Applications (WPF, WinForms, MAUI)
- ✅ Test Projects
- ✅ Azure Functions / Serverless
- ✅ Worker Services

**Note**: Adjust content based on your specific project type. Not all sections apply to all project types.

## Important Notes

- **DO NOT MOVE** these files from the AITransfer directory in the source repository
- These are **COPIES/TEMPLATES** — the originals remain for future use
- **Customization is required** — placeholders must be replaced with actual values
- **⚠️ Fix BOM encoding in global.json** — Always recreate JSON files without BOM
- Commit customized files to version control in new repositories
- Share with team members to ensure consistent AI assistance
- Update as project requirements evolve

## 🔄 Keeping AITransfer Templates Synchronized

**Critical for Source Repository Maintainers**

The `AITransfer/` directory contains template versions of active configuration files. As AI instructions and coding standards evolve in the active repository (`.github/`, `.junie/`, root configs), the templates **must be kept in sync**.

### Why Synchronization Matters

New repositories copy files from `AITransfer/`. If templates are outdated, new projects will:
- ❌ Start with obsolete coding standards
- ❌ Use deprecated patterns
- ❌ Miss new best practices
- ❌ Have inconsistent AI behavior

### Files Requiring Synchronization

| Active File | Template File | Sync Trigger |
|------------|---------------|--------------|
| `.github/copilot-instructions.md` | `AITransfer/copilot-instructions.md` | Coding standard updates, new patterns, build command changes |
| `.github/global-copilot-instructions.md` | `AITransfer/global-copilot-instructions.md` | General guideline updates |
| `.junie/guidelines.md` | `AITransfer/junie-guidelines.md` | Junie AI instruction updates |
| `.editorconfig` | `AITransfer/.editorconfig` | Code style rule changes |
| `.gitignore` | `AITransfer/.gitignore` | New ignore patterns |
| `.gitattributes` | `AITransfer/.gitattributes` | Git attribute changes |
| `global.json` | `AITransfer/global.json` | .NET SDK version updates |

### Synchronization Process

1. **Modify active file** (e.g., `.github/copilot-instructions.md`) and test changes
2. **Copy to AITransfer** directory
3. **Generalize content**:
   - Replace project-specific names with placeholders: `Learning_AdvancedCSharpStudies` → `[PROJECT_NAME]`
   - Replace version numbers with placeholders: `net10.0` → `net[version]`
   - Keep patterns, standards, and best practices unchanged
   - Add comments indicating customization points
4. **Review differences** to ensure no information loss
5. **Commit both files** together with descriptive message

### Example Workflow

```powershell
# 1. Update active file
# Edit .github/copilot-instructions.md with new standards

# 2. Copy to temp location for editing
Copy-Item -Path ".github\copilot-instructions.md" -Destination "AITransfer\copilot-instructions-temp.md"

# 3. Edit AITransfer\copilot-instructions-temp.md:
#    - Find: "Learning_AdvancedCSharpStudies" → Replace: "[PROJECT_NAME]"
#    - Find: "net10.0" → Replace: "net[version]"
#    - Find: "C# 14" → Replace: "C# [version]"
#    - Keep new coding patterns and standards intact

# 4. Compare changes
code --diff AITransfer\copilot-instructions.md AITransfer\copilot-instructions-temp.md

# 5. Apply changes
Move-Item -Path "AITransfer\copilot-instructions-temp.md" -Destination "AITransfer\copilot-instructions.md" -Force

# 6. Commit both
git add .github\copilot-instructions.md AITransfer\copilot-instructions.md
git commit -m "feat: Update coding standards and sync AITransfer template"
```

### AI Assistant Instructions

**For AI Assistants working in this repository:**

When you modify any file in `.github/`, `.junie/`, or root configuration files (`.editorconfig`, `.gitignore`, `.gitattributes`, `global.json`), you **must**:

1. ✅ Update the corresponding template in `AITransfer/` directory
2. ✅ Replace project-specific values with appropriate placeholders
3. ✅ Preserve new patterns, standards, and best practices
4. ✅ Commit both active and template files together

**Failure to sync templates means new repositories will start with outdated standards.**

---

## Creating a GitHub Remote Repository

After setup and customization, you'll want to push your repository to GitHub.

### Automated Script (Recommended)

Copy the `Setup-GitHubRemote.ps1` script from the example repository to automate the process:

```powershell
# Copy script to your repository
Copy-Item -Path "[source]\Setup-GitHubRemote.ps1" -Destination "Setup-GitHubRemote.ps1"

# Run the script
.\Setup-GitHubRemote.ps1
```

The script will:
- ✅ Check git status and commit changes
- ✅ Verify GitHub CLI installation
- ✅ Authenticate with GitHub
- ✅ Create repository
- ✅ Add remote and push code
- ✅ Open repository in browser

### Quick Methods

**Using GitHub CLI:**
```powershell
gh auth login
gh repo create YOUR_REPO_NAME --public --source=. --remote=origin --description "Your description"
git push -u origin main
```

**Manual:**
1. Create repo at https://github.com/new (don't initialize with files)
2. Run:
```powershell
git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git
git push -u origin main
```

For detailed instructions and troubleshooting, see `SETUP_GUIDE.md`.

---

## Troubleshooting

### BOM Encoding Issues

**Problem**: `dotnet` commands fail with JSON parsing errors after copying `global.json`

**Symptoms**:
- Error: "JSON standard does not allow such tokens"
- .NET CLI commands don't work
- IDE shows JSON errors on line 1

**Solution**: Recreate `global.json` without BOM (see step 2 above)

**Prevention**: Always use `-Encoding utf8NoBOM` when creating JSON files in PowerShell

### Placeholder Values Not Replaced

**Problem**: Files still contain `[PROJECT_NAME]` or other placeholders

**Solution**: Use find-and-replace in your editor to update all placeholders

**Files to check**:
- `.github/copilot-instructions.md`
- `.junie/guidelines.md`
- `global.json` (version number)

### Git Not Initialized

**Problem**: Git commands fail

**Solution**:
```powershell
git init
git add -A
git commit -m "Initial setup with AITransfer configuration"
```

### Build Fails After Setup

**Problem**: `dotnet build` fails after copying files

**Possible causes**:
1. BOM in `global.json` (most common)
2. SDK version mismatch
3. `.editorconfig` rules conflict with code

**Solutions**:
```powershell
# Fix BOM issue (see above)

# Check SDK version
dotnet --list-sdks

# Update global.json to match installed SDK
```

For more troubleshooting help, see `SETUP_GUIDE.md`.

---

## Additional Resources

### Documentation Files in This Directory

- **DIRECTORY_MAP.md** — Visual directory structure with file categories and quick setup
- **QUICK_REFERENCE.md** — Quick start guide with essential commands and tips
- **SETUP_GUIDE.md** — Detailed PowerShell commands and step-by-step setup instructions
- **CUSTOMIZATION_CHECKLIST.md** — Complete checklist for customizing all template files
- **INDEX.md** — Navigation guide to help you find what you need
- **REVIEW_SUMMARY.md** — Summary of genericization changes and improvements

**Start here**: If you're new to this, read `QUICK_REFERENCE.md` first for a fast overview, or check `DIRECTORY_MAP.md` for a visual guide.

## Last Updated

December 2, 2025