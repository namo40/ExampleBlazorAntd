# Blazor WebAssembly + Asp.net Hosted + Ant Design

목차
1. [Ant Design을 Client 프로젝트에 설치](#ant-design을-client-프로젝트에-설치)
2. [Ant Design Layout 적용하기](#ant-design-layout-적용하기)
3. [참고 자료](#참고-자료)

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

## Ant Design Layout 적용하기

적용 예)

![layout](./images/layout_sample.png)

[참고](https://antblazor.com/en-US/components/layout#components-layout-demo-side)

### Layout 수정하기

MainLayout.raozr를 통해 홈페이지의 전체 Layout을 만들 수 있습니다.

Page에 내용은 @Body를 통해 출력이 됩니다.

1. layout 수정 하기
   ```csharp
   <Layout Style="min-height: 100vh; ">
       <Sider Collapsible>
           <div class="logo"/>
           <Menu Theme="MenuTheme.Dark" DefaultSelectedKeys=@(new[] { "1" }) Mode="MenuMode.Inline">
               <MenuItem Key="1" RouterLink="/" RouterMatch="NavLinkMatch.All">
                   <Icon Type="@IconType.Outline.Home" Theme="outline"/>
                   <span>Home</span>
               </MenuItem>
               <MenuItem Key="2" RouterLink="Dashboard" RouterMatch="NavLinkMatch.Prefix">
                   <Icon Type="@IconType.Outline.Dashboard" Theme="outline"/>
                   <span>Dashboard</span>
               </MenuItem>
               <MenuItem Key="3" RouterLink="Users" RouterMatch="NavLinkMatch.Prefix">
                   <Icon Type="@IconType.Outline.User" Theme="outline"/>
                   <span>Users</span>
               </MenuItem>
           </Menu>
       </Sider>
       <Layout Class="site-layout">
           <Header Class="site-layout-background" Style=" padding: 0 ;"></Header>
           <Content Style="margin:0 16px;">
               <div class="site-layout-background" style="margin-top:24px; padding: 24px; min-height: 360px">
                   @Body
               </div>
           </Content>
           <Footer Style="text-align:center ">Ant Design ©2018 Created by Ant UED</Footer>
       </Layout>
   </Layout>
   ```
2. 전역 css 추가 하기
   ```css
   /* wwwroot/css/app.css */
   
   .logo {
       height: 32px;
       background: rgba(255, 255, 255, 0.2);
       margin: 16px;
   }
   
   .site-layout .site-layout-background {
       background: #fff;
   }
   ```

## 참고 자료

- Ant Design Blazor : https://antblazor.com/en-US/
- Ant Design Component : https://antblazor.com/en-US/components/overview