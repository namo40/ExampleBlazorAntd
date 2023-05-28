# Blazor WebAssembly + Asp.net Hosted + Ant Design

목차
1. [Ant Design을 Client 프로젝트에 설치](#ant-design을-client-프로젝트에-설치)
2. [참고 자료](#참고-자료)

## Ant Design을 Client 프로젝트에 설치

1. AntDesign Package를 설치 합니다. (샘플 설치 버전 : 0.15.0)
2. Service를 추가 합니다.
   ```csharp
   // Program.cs

    builder.Services.AddAntDesign();
   ```
3. Ant Design의 css와 js를 추가 합니다.
   ```html
   <!-- wwwroot/index.html -->
   
   <link href="_content/AntDesign/css/ant-design-blazor.css" rel="stylesheet" />
   <script src="_content/AntDesign/js/ant-design-blazor.js"></script>
   ```
4. 전역으로 사용 할 수 있도록 namespace 추가 합니다.
   ```csharp
   // _Imports.razor 
   
   @using AntDesign
   ```
5. 팝업 구성 요소를 동적으로 표시 하기 위해 구성 요소를 추가 합니다.
   ```csharp
   // App.razor
   
   <AntContainer />
   ```
6. (적용 확인) Ant Design Component를 사용해 봅니다.
   ```csharp
   // Pages/Index.razor
   
   <Button Type="@ButtonType.Primary">Hello, world!</Button>
   ```
   동작 이미지

   ![button](./images/button_sample.png)

## 참고 자료

- Ant Design Blazor : https://antblazor.com/en-US/
- Ant Design Component : https://antblazor.com/en-US/components/overview